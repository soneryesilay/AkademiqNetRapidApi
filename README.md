# AkademiqNetRapidApi

Bu proje, çeşitli RapidAPI servislerini kullanarak gerçek zamanlı verileri gösteren bir ASP.NET Core web uygulamasıdır.

## Özellikler

- Güncel döviz kurları (EUR/TRY, USD/TRY)
- İstanbul'daki güncel akaryakıt fiyatları
- İstanbul için 3 saatlik hava durumu tahmini
- Popüler kripto para birimlerinin fiyatları (ETH, DOGE, SOL, JUP)
- Rastgele yemek tarifleri
- Teknoloji haberleri

## Başlangıç

### Gereksinimler

- .NET 7.0 veya üzeri
- Visual Studio 2022 veya Visual Studio Code
- RapidAPI hesabı ve API anahtarları

### Kurulum ve Çalıştırma

1. Projeyi klonlayın:
```bash
git clone https://github.com/kullaniciadi/AkademiqNetRapidApi.git
```

2. Proje dizinine gidin:
```bash
cd AkademiqNetRapidApi
```

3. `appsettings.example.json` dosyasını `appsettings.json` olarak kopyalayın:
```bash
cp appsettings.example.json appsettings.json
```

4. `appsettings.json` dosyasını düzenleyerek RapidAPI anahtarınızı ekleyin:
```json
{
  "RapidApi": {
    "Key": "YOUR_RAPID_API_KEY_HERE"
  }
}
```

5. Uygulamayı başlatmak için:

Visual Studio ile:
- Visual Studio'da projeyi açın
- F5 tuşuna basın veya IIS Express butonuna tıklayın
- Tarayıcınızda `https://localhost:5001` adresine gidin

Visual Studio Code ile:
```bash
dotnet restore
dotnet build
dotnet run
```
- Tarayıcınızda `https://localhost:5001` adresine gidin

## Kullanılan API'ler

- Currency Conversion API
- Akaryakıt Fiyatları API
- Weather API
- Binance API
- TheMealDB API
- Real-time News Data API

## Güvenlik

- API anahtarlarınızı asla doğrudan kod içerisinde saklamayın
- `appsettings.json` dosyasını `.gitignore` dosyasına eklediğinizden emin olun
- Hassas bilgileri içeren dosyaları asla GitHub'a pushlamayın

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakın.

