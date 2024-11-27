namespace OnlineSurvey.Business.Constants
{
    public static class Messages
    {
        public static string UserRegistered = "Kullanıcı başarılı bir şekilde kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string WrongPassword = "Parola hatası";
        public static string LoginSuccessful = "Başarılı giriş";
        public static string UserAlreadyExist = "Kullanıcı mevcut";
        public static string TokenCreated = "Token oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok!";
        public static string NameIsNotEmpty = "Adı boş geçilemez";
        public static string SurnameIsNotEmpty = "Soyadı boş geçilemez";
        public static string EmailIsNotEmpty = "Email adresi boş geçilemez!";
        public static string PasswordIsNotEmpty = "Şifre boş geçilemez!";

        public static string OptionsListed = "Seçenekler listelendi.";
        public static string NamedOptionAdded = " adlı seçenek eklendi.";
        public static string NamedOptionUpdated = " adlı seçenek güncellendi.";
        public static string ErrorWhileNamedOptionAdded = " adlı seçenek eklenirken bir hata oluştu!";
        public static string ErrorWhileNamedOptionUpdated = " adlı seçenek güncellenirken bir hata oluştu!";

        public static string PollsListed = "Anketler listelendi.";
        public static string PollListed = "Anket listelendi.";
        public static string NamedPollAdded = " adlı anket eklendi.";
        public static string ErrorWhileNamedPollAdded = " adlı anket eklenirken bir hata oluştu!";
        public static string PollMustHaveAtLeastTwoOptions = "Bir ankette en az iki seçenek bulunmalıdır";
    }
}
