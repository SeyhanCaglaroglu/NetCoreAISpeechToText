# Speech to Text

![Speech to Text](/NetCoreAI_01_OpenWhisperAudioTranskript/SpeechToTextt.jpg)

Bu mini projede bir ses dosyasýndaki tüm konuþulan kelimeleri, OpenAI modeli ile nasýl metne dönüþtüreceðimizi anlatýyorum. (En az 5$ lýk bir ödeme istiyor, vergi ile 6$ tutuyor)

- Öncelikle OpenAI dan bir Apikey alýnmalý, bunun için platform.openai.com sitesine giriþ yapýp, sol üst köþedeki search kýsmýna Apikey yazarak, çýkan linke týplayýp ilgili sayfada create kýsmýndan Apikey'i oluþturuyoruz.
- Bu hizmetlerden yararlanabilmek için, tekrar search kýsmýna Billing yazarak ilgili linke týkladýkdan sonra, açýlan sayfada 0.00$ olarak görünen bakiyemizi artýrmak için Add payment details butonuna týklayarak kart bilgilerimizi girip ileri dedikden sonra, ikinci kýsýmda en az 5$ lýk bir ücret girmemizi talep ediyor. Hemen altýndaki seçili checkbox da ise bu ödemenin otomatik olarak devam edip etmiceðini soruyor, bunun iþaretini kaldýrýp devam ettikden sonra telefonunuza mesaj da gelebilir, direk alýmý gerçekleþtiredebilir.
- Artýk Kod kýsmýna geçebiliriz.

# Kod Kýsmý

![Speech to Text](/NetCoreAI_01_OpenWhisperAudioTranskript/SpeechToTextCode.png)

- 1 numaralý satýrda OpenAI dan aldýðýmýz key i yazýyoruz.
- 2 numaralý satýrda ses dosyamýzýn adýný, varsa üst klasörü klasör adýyla birlikte
- 3 den 4 e kadar olan kýsýmda ise, bir HttpClient oluþturup, Authorization kýsmýna Apikey i yazýp, Ses dosyasýný ve model bilgisini göndermek için çok parçalý (multipart) form verisi oluþturulur. Ardýndan ses dosyasý byte dizisine dönüþtürüldükden sonra MIME türü (audio/mpeg) belirtilir. Ses dosyasý forma eklenir. "file" parametresi, API'nin beklediði isimdir. Son olarak OpenAI'nin Whisper modeli kullanýlacaðý belirtilir.
- 4 numaralý satýrda OpenAI ýn audio API sine form verisi gönderilir. 
- 5 numaralý kýsýmda, eðer istek baþarýlý ise sonuç döndürülür. Artýk çýktýyý console da görebilirsiniz.

![Speech to Text](/NetCoreAI_01_OpenWhisperAudioTranskript/SpeechToTextResult.png)

# Not: 
- Apileri her kullandýðýnýzda 5$ lýk veya aldýðýnýz kredi neyse azalmaktadýr. Yine Billing kýsmýndan kontrol edilmeli !