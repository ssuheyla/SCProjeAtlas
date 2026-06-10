.NET 8 ile geliştirilmiş basit bir sohbet API si.

Gereksinimler
.NET 8 SDK

Kurulum ve Çalıştırma
bash dotnet restore
dotnet build
dotnet run
Uygulama çalıştıktan sonra terminalde görünen adres üzerinden Swagger arayüzüne ulaşılabilir.

Kullanım
POST /api/Chat
json{
  "message": "merhaba"
}

message alanı zorunludur, boş gönderilirse API 400 Bad Request döner.

Proje Yapısı

---Controllers
ChatController.cs   // POST /api/chat endpoint

---Models
ChatRequest.cs      // modeller
ChatResponse.cs 

---Services 
IChatService.cs     // Servis arayüzü
ChatService.cs      // İş mantığı

---Program.cs       // DI, Swagger


Teknolojiler

.NET 8

ASP.NET Core Web API

Swagger 





