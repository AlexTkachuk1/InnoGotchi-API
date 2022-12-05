﻿using InnoGotchi.DAL.Entities;

namespace InnoGotchi.BLL.DTO
{
    public class UserDTO
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string AvatarImg { get; set; }
        public string Passvord { get; set; }
        public virtual List<FarmDTO> Farms { get; set; }

    }
}
