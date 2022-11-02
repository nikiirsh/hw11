namespace hw11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book1= new hw11.Books();
            book1.Autors = "Эрих Мария Ремарк";
            book1.Name = "Три Товарища";
            book1.Genre = "Роман";

            var book2= new hw11.Books();
            book2.Autors = "Донато Карризи";
            book2.Name = "Подсказчик";
            book2.Genre = "Детектив";

            var book3= new hw11.Books();
            book3.Autors = "Габриэль Гарсия Маркес";
            book3.Name = "Сто лет одиночества";
            book3.Genre = "Роман";

            var book4 = new hw11.Books("Лолита", "В. Набоков", "Роман");

            var worker1 = new hw11.Staff("01/10/2000", "Назар", "Продавец-консультант");
            var worker2 = new hw11.Staff("21/10/1990", "Дмитрий", "Менеджер");
            var worker3 = new hw11.Staff("12/12/1988", "Константин", "Владелец-продавец");

            worker1.SetPhone("0994837333");
            
        }
        
    }
}