﻿namespace dotnetapp.Models
{
    public class Team{
        public int TeamId{get;set;}

        public string? TeamName{get;set;}

        public ICollection<Player>? Players{get;set;}
    }

}