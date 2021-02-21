using System;

namespace GameProject
{
    class SalesCaampaignManager : ISalesCampaignService
    {
        public void Add(SalesCampaign salesCampaign)
        {
            Console.WriteLine(salesCampaign.SalesCampaignName + "özel kampanyasi baslatildi");
            Console.WriteLine();
        }

        public void Delete(SalesCampaign salesCampaign)
        {
            Console.WriteLine(salesCampaign.SalesCampaignName + "özel kampanya Silindi");
            Console.WriteLine();
        }

        public void Update(SalesCampaign salesCampaign)
        {
            Console.WriteLine(salesCampaign.SalesCampaignName + "özel kampanya Güncenlendi");
            Console.WriteLine();
        }
    }
}
