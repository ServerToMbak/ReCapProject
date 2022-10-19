using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constanrs
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";

        public static string CarCouldntAdded = "Araba Eklenemedi";
        public static string CarListed = "Arabalar Listelendi";
        public static string ColorAdded = "Renk Eklendi";
        public static string RentalAdded = "Rental Added";

        public static string RentalAddingError = "Rental Didn't Add";

        public static string CarImageLimitExceeded = "arabaya daha fazla resim ekleyemezsin";

        public static string CarImageUpdated = "Araba resmi güncellendi ";

        public static string CarImageDeleted = "Araba resmi silindi";

        public static string CarImageAdded = "Araba resmi eklendi";

        public static string ColorNameAlreadyExists = "Bu İsimde Bir Renk zaten Var!";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
