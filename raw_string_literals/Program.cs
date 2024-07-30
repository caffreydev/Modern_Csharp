var code = """"
var title = "What's new in C# 11?";

var json = $$"""
    [
        {
            "title": "{{title}}",
            "url": "https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11"
        },

        {
            "title": "What's new in C# 10?",
            "url": "https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10"
        }
    ]
    """;

WriteLine(json);
"""";

WriteLine(code);