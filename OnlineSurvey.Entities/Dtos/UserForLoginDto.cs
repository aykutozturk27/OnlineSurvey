﻿using OnlineSurvey.Core.Entities;

namespace OnlineSurvey.Entities.Dtos
{
    public class UserForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
