import pyshorteners

url = input("🔗 Enter a URL to shorten: ")
s = pyshorteners.Shortener()
short_url = s.tinyurl.short(url)
print("✅ Shortened URL:", short_url)
