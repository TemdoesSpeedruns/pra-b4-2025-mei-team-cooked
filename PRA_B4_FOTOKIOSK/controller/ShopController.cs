using PRA_B4_FOTOKIOSK.magie;
using PRA_B4_FOTOKIOSK.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA_B4_FOTOKIOSK.controller
{
    public class ShopController
    {
        public static Home Window { get; set; }

        public void Start()
        {
            // Voeg producten toe met prijs en beschrijving
            ShopManager.Products.Add(new KioskProduct()
            {
                Name = "Foto 15x20",
                Price = 4.00,
                Description = "Een afgedrukte foto van 15x20 cm."
            });

            ShopManager.Products.Add(new KioskProduct()
            {
                Name = "Sleutelhanger",
                Price = 7.00,
                Description = "Een sleutelhanger met jouw foto."
            });

            ShopManager.Products.Add(new KioskProduct()
            {
                Name = "Mok",
                Price = 9.33,
                Description = "Een keramische mok met een eigen foto."
            });

            ShopManager.Products.Add(new KioskProduct()
            {
                Name = "T-shirt",
                Price = 12.69,
                Description = "Een bedrukt t-shirt met een afbeelding naar keuze."
            });

            // Zet de prijslijst bovenaan opnieuw op
            ShopManager.SetShopPriceList("Prijslijst:\n");

            // Voeg elk product toe aan de prijslijst
            foreach (KioskProduct product in ShopManager.Products)
            {
                string regel = $"{product.Name} - €{product.Price:F2}\n{product.Description}\n";
                ShopManager.AddShopPriceList(regel);
            }

            // Werk de dropdown bij met alle producten
            ShopManager.UpdateDropDownProducts();

            // Zet standaardtekst op de bon
            ShopManager.SetShopReceipt("Eindbedrag\n€");
        }

        public void AddButtonClick()
        {
            // Deze komt bij user story C1
        }

        public void ResetButtonClick()
        {
            // Reset functionaliteit 
        }

        public void SaveButtonClick()
        {
            // Opslaan van bon
        }
    }
}
