using CourseWork.Model;
using CourseWork.Presenter;

namespace CourseWork
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var view = new MainView();
            // model
            var users_model = new UsersModel();
            var clients_model = new ClientsModel();
            var products_model = new ProductsModel();
            var orders_model = new OrdersModel();

            
      
            // presenter
            var presenter = new MainPresenter(users_model, view, clients_model,products_model,orders_model);
            Application.Run(view);


        }
    }
}