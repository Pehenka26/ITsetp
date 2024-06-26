﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITstep.Domen.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }   
    public string? Deportament {  get; set; }
    public int? Score { get; set; } = 0;
    public bool? IsPassed { get; set; } = false;
    public string? Photo { get; set; } = "https://amu.edu.kz/upload/default-avatar.jpg";
}
