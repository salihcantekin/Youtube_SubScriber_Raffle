using Bogus;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using SubScriberRaffle.Models;
using System.Text.Json;

namespace SubScriberRaffle;
public class YoutubeDataProvider
{
    public class Rootobject
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string nextPageToken { get; set; }
        public Pageinfo pageInfo { get; set; }
        public Item[] items { get; set; }
    }

    public class Pageinfo
    {
        public int totalResults { get; set; }
        public int resultsPerPage { get; set; }
    }

    public class Item
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string id { get; set; }
        public Snippet snippet { get; set; }
    }

    public class Snippet
    {
        public string videoId { get; set; }
        public Toplevelcomment topLevelComment { get; set; }
        public bool canReply { get; set; }
        public int totalReplyCount { get; set; }
        public bool isPublic { get; set; }
    }

    public class Toplevelcomment
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string id { get; set; }
        public Snippet1 snippet { get; set; }
    }

    public class Snippet1
    {
        public string videoId { get; set; }
        public string textDisplay { get; set; }
        public string textOriginal { get; set; }
        public string authorDisplayName { get; set; }
        public string authorProfileImageUrl { get; set; }
        public string authorChannelUrl { get; set; }
        public Authorchannelid authorChannelId { get; set; }
        public bool canRate { get; set; }
        public string viewerRating { get; set; }
        public int likeCount { get; set; }
        public DateTime publishedAt { get; set; }
        public DateTime updatedAt { get; set; }
    }

    public class Authorchannelid
    {
        public string value { get; set; }
    }


    private static readonly string filePath = "Comments.txt";

    public static async Task<List<UserProfileDetail>> Get(bool useDummyData = false, bool fromLocalFile = false)
    {
        var list = new List<UserProfileDetail>();
        CommentThreadListResponse response = null;

        if (useDummyData)
        {
            list = GetDummyResponse();
            goto result;
        }

        if (fromLocalFile)
        {
            list = await LoadFromLocalFile();
            goto result;
        }

        var youtubeService = new YouTubeService(new BaseClientService.Initializer()
        {
            ApiKey = Constants.ApiKey,
            ApplicationName = Environment.UserDomainName
        });

        var nextPageToken = "";

        if (File.Exists(filePath))
            File.Delete(filePath);

        File.Create(filePath).Close();

        while (nextPageToken != null)
        {
            var request = youtubeService.CommentThreads.List("snippet");
            request.VideoId = Constants.VideoId;
            request.PageToken = nextPageToken;
            response = await request.ExecuteAsync();

            await AppendDummyData(response);

            var newList = ConvertToUserProfile(response.Items);

            list.AddRange(newList);

            nextPageToken = response.NextPageToken;
        }

    result:

        list = Filter(list);

        list = list
            .DistinctBy(i => i.UserName)
            .ToList();

        return list;
    }

    private static List<UserProfileDetail> GetDummyResponse()
    {
        Image img = Image.FromFile($"c:\\default.png");
        return new Faker<UserProfileDetail>("tr")
            .RuleFor(i => i.Image, i => img)
                .RuleFor(i => i.UserName, i => i.Internet.UserName())
                .RuleFor(i => i.Comment, i => i.Lorem.Sentence(5, 10))
            .Generate(100);
    }

    private static IEnumerable<UserProfileDetail> ConvertToUserProfile(IEnumerable<CommentThread> comments)
    {
        return comments.Select(i => new UserProfileDetail()
        {
            Id = i.Snippet.TopLevelComment.Id,
            UserName = i.Snippet.TopLevelComment.Snippet.AuthorDisplayName,
            Comment = i.Snippet.TopLevelComment.Snippet.TextOriginal,
            ImageUrl = i.Snippet.TopLevelComment.Snippet.AuthorProfileImageUrl
        });
    }

    private static async Task<List<UserProfileDetail>> LoadFromLocalFile()
    {
        if (!File.Exists(filePath))
            return new List<UserProfileDetail>();

        var fileContent = await File.ReadAllTextAsync(filePath);
        var obj = JsonSerializer.Deserialize<CommentThreadListResponse>(fileContent);

        return ConvertToUserProfile(obj.Items).ToList();
    }

    private static async Task AppendDummyData(CommentThreadListResponse response)
    {
        var fileContent = await File.ReadAllTextAsync(filePath);
        CommentThreadListResponse fileContentObj;

        if (!string.IsNullOrEmpty(fileContent))
        {
            fileContentObj = JsonSerializer.Deserialize<CommentThreadListResponse>(fileContent);
            if (fileContentObj.Items is null)
                fileContentObj.Items = new List<CommentThread>();

            response.Items.ToList().ForEach(i => fileContentObj.Items.Add(i));
        }
        else
        {
            fileContentObj = response;
        }


        await File.WriteAllTextAsync(filePath, JsonSerializer.Serialize(fileContentObj));
    }

    private static List<UserProfileDetail> Filter(List<UserProfileDetail> list)
    {
        string[] filterMessages = new[] 
        { 
            "çok güzel bir kanal", 
            "çok faydalı bir kanal, başarılarınızın devamını dilerim", 
            "çok güzel bir kanal büyümeyi hak ediyor" 
        };

        return list.Where(i => !filterMessages.Contains(i.Comment)).ToList();
    }
}
