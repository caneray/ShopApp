#Projeyi SQL Servera çekmek için;

###Ana Dizinde iken;

1. dotnet ef migrations add InitialCreate --context ApplicationContext --startup-project shopapp.webui

2. dotnet ef migrations add InitialCreate --context ApplicationContext --startup-project shopapp.webui --project shopapp.data

NOT;
* Projenin başlangıç ayarları yapılmalı webui a başlama verilmeli
* appsettings.json dosyasında bulunan sql server yolu bilgisayara göre değiştirilmeli
