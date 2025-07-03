# Speech to Text

![Speech to Text](/NetCoreAI_01_OpenWhisperAudioTranskript/SpeechToTextt.jpg)

Bu mini projede bir ses dosyas�ndaki t�m konu�ulan kelimeleri, OpenAI modeli ile nas�l metne d�n��t�rece�imizi anlat�yorum. (En az 5$ l�k bir �deme istiyor, vergi ile 6$ tutuyor)

- �ncelikle OpenAI dan bir Apikey al�nmal�, bunun i�in platform.openai.com sitesine giri� yap�p, sol �st k��edeki search k�sm�na Apikey yazarak, ��kan linke t�play�p ilgili sayfada create k�sm�ndan Apikey'i olu�turuyoruz.
- Bu hizmetlerden yararlanabilmek i�in, tekrar search k�sm�na Billing yazarak ilgili linke t�klad�kdan sonra, a��lan sayfada 0.00$ olarak g�r�nen bakiyemizi art�rmak i�in Add payment details butonuna t�klayarak kart bilgilerimizi girip ileri dedikden sonra, ikinci k�s�mda en az 5$ l�k bir �cret girmemizi talep ediyor. Hemen alt�ndaki se�ili checkbox da ise bu �demenin otomatik olarak devam edip etmice�ini soruyor, bunun i�aretini kald�r�p devam ettikden sonra telefonunuza mesaj da gelebilir, direk al�m� ger�ekle�tiredebilir.
- Art�k Kod k�sm�na ge�ebiliriz.

# Kod K�sm�

![Speech to Text](/NetCoreAI_01_OpenWhisperAudioTranskript/SpeechToTextCode.png)

- 1 numaral� sat�rda OpenAI dan ald���m�z key i yaz�yoruz.
- 2 numaral� sat�rda ses dosyam�z�n ad�n�, varsa �st klas�r� klas�r ad�yla birlikte
- 3 den 4 e kadar olan k�s�mda ise, bir HttpClient olu�turup, Authorization k�sm�na Apikey i yaz�p, Ses dosyas�n� ve model bilgisini g�ndermek i�in �ok par�al� (multipart) form verisi olu�turulur. Ard�ndan ses dosyas� byte dizisine d�n��t�r�ld�kden sonra MIME t�r� (audio/mpeg) belirtilir. Ses dosyas� forma eklenir. "file" parametresi, API'nin bekledi�i isimdir. Son olarak OpenAI'nin Whisper modeli kullan�laca�� belirtilir.
- 4 numaral� sat�rda OpenAI �n audio API sine form verisi g�nderilir. 
- 5 numaral� k�s�mda, e�er istek ba�ar�l� ise sonu� d�nd�r�l�r. Art�k ��kt�y� console da g�rebilirsiniz.

![Speech to Text](/NetCoreAI_01_OpenWhisperAudioTranskript/SpeechToTextResult.png)

# Not: 
- Apileri her kulland���n�zda 5$ l�k veya ald���n�z kredi neyse azalmaktad�r. Yine Billing k�sm�ndan kontrol edilmeli !