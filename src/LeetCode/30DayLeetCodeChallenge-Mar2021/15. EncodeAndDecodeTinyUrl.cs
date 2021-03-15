/*
#535 - https://leetcode.com/problems/encode-and-decode-tinyurl/

Note: This is a companion problem to the System Design problem: Design TinyURL.
TinyURL is a URL shortening service where you enter a URL such as https://leetcode.com/problems/design-tinyurl and it returns a short URL such as http://tinyurl.com/4e9iAk.

Design the encode and decode methods for the TinyURL service. There is no restriction on how your encode/decode algorithm should work. You just need to ensure that a URL can be encoded to a tiny URL and the tiny URL can be decoded to the original URL.
*/

using System.Collections.Generic;

public class EncodeAndDecodeTinyUrl
{
    Dictionary<string, string> urls = new Dictionary<string, string>();
    // Encodes a URL to a shortened URL
    public string encode(string longUrl)
    {
        urls.Add(longUrl.GetHashCode().ToString(), longUrl);
        return longUrl.GetHashCode().ToString();
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl)
    {
        return urls[shortUrl];
    }
}

// Your EncodeAndDecodeTinyUrl object will be instantiated and called as such:
// EncodeAndDecodeTinyUrl codec = new EncodeAndDecodeTinyUrl();
// codec.decode(codec.encode(url));