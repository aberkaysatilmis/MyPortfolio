﻿namespace MyPortfolio.DataAccessLayer.Entities
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public string Title { get; set; }
        public string SubDescription { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string DataSize { get; set; }
    }
}