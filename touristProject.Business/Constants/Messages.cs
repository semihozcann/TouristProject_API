using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace touristProject.Business.Constants
{
    public static class Messages
    {

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserRegistered = "Kayıt Başarılı";
        public static string UserNotFound = "Kullanıcı adı veya şifre hatalı";
        public static string PasswordError = "Hatalı şifre girdiniz.";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Bu email üzerine kayıtlı kullanıcı bulunmaktadır.";
        public static string AccessTokenCreated = "Access Token oluşturuldu";
        public static string MailNotEmpty = "Mail kısmı boş kalamaz.";
        public static string EmailTooLong = "Mail en fazla 150 karakter olabilir.";
        public static string FirstNameNotEmpty = "İsim kısmı boş olamaz";
        public static string FirstNameTooLong = "İsim kısmı en fazla 50 karakter olabilir.";
        public static string LastNameNotEmpty = "Soyisim kısmı boş olamaz";
        public static string LastNameTooLong = "Soyisim kısmı en fazla 100 karakter olabilir.";

        public static string AuthorizationDenied = "Yetkiniz Yok.";


        public static string CategoryAdded = "Kategori eklendi";
        public static string CategoryUpdated = "Kategori güncellendi";
        public static string CategoryGeted = "Kategori detayları getirildi";
        public static string CategoryListed = "Kategori listelendi";
        public static string CategoryDeleted = "Kategori silindi";
        public static string CategoryNotFound = "Kategori bulunamadı";
        public static string CategoryNameNotEmpty = "Kategori adı boş olamaz";
        public static string CategoryNameMaxLength = "Kategori adı 50 karakterden fazla olamaz";
        public static string CategoryNameAlreadyExist = "Aynı isimde bir kategori mevcut";

        public static string NutrientAdded = "Besin eklendi";
        public static string NutrientUpdated = "Besin güncellendi";
        public static string NutrientGeted = "Besin detayı getirildi";
        public static string NutrientListed = "Besinler listelendi";
        public static string NutrientDeleted = "Besin silindi";
        public static string NutrientNotFound = "Besin bulunamadı";

        public static string NutrientImageAdded = "Fotoğraf eklendi";
        public static string NutrientImageUpdated = "Fotoğraf güncellendi";
        public static string NutrientImageGeted = "Fotoğraf getirildi";
        public static string NutrientImageListed = "Fotoğraflar listelendi";
        public static string NutrientImageDeleted = "Fotoğraf silindi";
        public static string NutrientImageNotFound = "Fotoğraf bulunamadı";



    }
}
