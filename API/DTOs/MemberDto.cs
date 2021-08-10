using System;
using System.Collections.Generic;

namespace API.DTOs
{
    public class MemberDto
    {
        //public MemberDto(int id, string userName, int age, string knownAs, DateTime created, DateTime lastActive, string gender, string introduction, string lookingFor, string interests, string city, string country) 
        //{
        //    this.Id = id;
        //    this.Username = userName;
        //    this.Age = age;
        //    this.KnownAs = knownAs;
        //    this.Created = created;
        //    this.LastActive = lastActive;
        //    this.Gender = gender;
        //    this.Introduction = introduction;
        //    this.LookingFor = lookingFor;
        //    this.Interests = interests;
        //    this.City = city;
        //    this.Country = country;
   
        //}
        public int Id { get; set; }

        public string Username { get; set; }

        public string PhotoUrl { get; set; }

        public int Age { get; set; }

        public string KnownAs { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastActive { get; set; }

        public string Gender { get; set; }

        public string Introduction { get; set; }

        public string LookingFor { get; set; }

        public string Interests { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public ICollection<PhotoDto> Photos { get; set; }
    }
}