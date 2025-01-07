namespace ASP.NET_LEARNİNG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //Burası Proje ayağa kalkmadan öcnbe yapıalcak şeylerın oldugu yerdır.
            //Servis kısmı burasıdır
            //Mvc olarak çalışması, dependecy ınjectıon, IoS Contaıner yapıları burada yapılacak, Database hangısı bunları proje calısmadan once soylememız gerekır. 
            builder.Services.AddControllersWithViews();
            
            var app = builder.Build();
            
            //Bu kısım ise MıddleVer yukarıda yukledıgımız servıslerın metotları fonksıyonları guvenlık ıslemelrı burada yapılır routıng metotları vesaire de burada ayarlanır.
            //var ıd = 45;
            //app.MapGet("/", () => "Hello World!");
            //app.MapGet("/Product", () => "Ürünler Hazırlanıyor.....");//Burada da sadece /Gidecegi yer ve ne gostereceği soylenir.
            //app.MapGet($"/Product/Index", () => ıd );
            app.UseHttpsRedirection();
            app.UseRouting();
            //app.MapDefaultControllerRoute();//MVC nın bır arayuzu ilk / Controllera gider ıkıncıu / Actiona gider / ıse ıd parametresı varsa onu dondurur.
            app.MapControllerRoute(
                name: "default",//Default route hep en sonda olmalı kı en sonu onu okusun ve bulamazsa oraya gıtsın dıye;
                pattern: "{controller=Home}/{action=Index}/{id?}");
            //app.MapControllerRoute(
            //    name:"Product",//Product sayfası için bir yol harıtası yapıyoruz.
            //    pattern: "products/{controller=Home}/{action=Index}/{id}/{orderBy}");
            app.Run();
        }
    }
}
