﻿using System.Net.Http.Headers;


string apiKey = "buraya openai dan alinan api key gelicek"; //1

string audioFilePath = "audio1.mp3"; //2

using (var httpclient = new HttpClient()) //3
{
    httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

    var form = new MultipartFormDataContent();

    var audioContent = new ByteArrayContent(File.ReadAllBytes(audioFilePath));
    audioContent.Headers.ContentType = MediaTypeHeaderValue.Parse("audio/mpeg");

    form.Add(audioContent, "file", Path.GetFileName(audioFilePath));
    form.Add(new StringContent("whisper-1"), "model");

    Console.WriteLine("Ses dosyası işleniyor lütfen bekleyiniz...");

    var response = await httpclient.PostAsync("https://api.openai.com/v1/audio/transcriptions", form); //4

    if (response.IsSuccessStatusCode) //5
    {
        var result = await response.Content.ReadAsStringAsync();

        Console.WriteLine("Transkript: ");
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine($"Hata: {response.StatusCode}");
        Console.WriteLine(await response.Content.ReadAsStringAsync());
    }
}



