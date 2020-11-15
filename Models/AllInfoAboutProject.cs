﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamBuilder.Models
{
    public class AllInfoAboutProject
    {
        //Вся информация о пользователях и администраторах в проекте
        public bool IsUserAdmin { get; set; }
        public IEnumerable<User> ProjectAdmins { get; set; }
        public IEnumerable<User> AllAdmins { get; set; }
        public IEnumerable<User> UsersInTeams { get; set; }
        public Project Project { get; set; }
    }
}
