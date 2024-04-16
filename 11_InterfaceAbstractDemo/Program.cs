using _11_InterfaceAbstractDemo.Abstract;
using _11_InterfaceAbstractDemo.Adapters;
using _11_InterfaceAbstractDemo.Concrete;
using _11_InterfaceAbstractDemo.Entities;

namespace _11_InterfaceAbstractDemo
{
    internal class Program
    {
//        SOLID
//        S — Single-responsibility principle
//        ÖZET: Bir sınıf(nesne) yalnızca bir amaç uğruna değiştirilebilir, o da o sınıfa yüklenen sorumluluktur, yani bir sınıfın(fonksiyona da indirgenebilir) yapması gereken yalnızca bir işi olması gerekir.

//        O — Open-closed principle
//        ÖZET: Bir sınıf ya da fonksiyon halihazırda var olan özellikleri korumalı ve değişikliğe izin vermemelidir.Yani davranışını değiştirmiyor olmalı ve yeni özellikler kazanabiliyor olmalıdır.

//        L — Liskov substitution principle
//        ÖZET: Kodlarımızda herhangi bir değişiklik yapmaya gerek duymadan alt sınıfları, türedikleri(üst) sınıfların yerine kullanabilmeliyiz.

//        I — Interface segregation principle
//        ÖZET: Sorumlulukların hepsini tek bir arayüze toplamak yerine daha özelleştirilmiş birden fazla arayüz oluşturmalıyız.

//        D — Dependency Inversion Principle
//        ÖZET: Sınıflar arası bağımlılıklar olabildiğince az olmalıdır özellikle üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            Customer customer = new Customer{ Id=1,FirstName="Ali", LastName="Kulu",DateOfBirth=new DateTime(1988,10,24), NationalityId="123456789111" };
            
            
        }
    }
}
