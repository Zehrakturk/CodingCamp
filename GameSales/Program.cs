using video5_odev5.Concrete;
using video5_odev5.Entitiy;

internal class Program
{
    private static void Main(string[] args)
    {
        Gamer gamer = new Gamer
        {
            FirstName = "Zehra",
            LastName = "Aktürk",
            Email = "zehra.akturk15@gmail.com",
            Id = 1,
            Password = "123456",
            UserName="zehrakturk_"

        };
       
        GamerManager gamerManager=new GamerManager(new CheckManager());
       // gamerManager.Delete(gamer);

        Game game = new Game();
        game.GameName = "CS Go";
        game.Id = 1;
        game.Price = 2435;

        Campaign campaign = new Campaign
        {
            CampaignName = "Student Campaign",
            Id = 1,

        };
        
        GameSalesManager gameSalesManager=new GameSalesManager(new CheckManager());
        gameSalesManager.AddToCart(gamer, game, campaign);

        CampaignManager campaignManager = new CampaignManager();
       // campaignManager.DeleteCampaign(campaign);
   
    }
}