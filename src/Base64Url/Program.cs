if (args.Length == 0) {
    Console.WriteLine("Please provide a URL to convert to Base64.");
    return;
}

var url = args[0];

using (var client = new HttpClient()) {
    byte[] imageBytes = await client.GetByteArrayAsync(url);
    var base64String = Convert.ToBase64String(imageBytes);
    Console.WriteLine(base64String);
}