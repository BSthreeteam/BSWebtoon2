﻿using BSWebtoon.Model.Models;
using Microsoft.AspNetCore.Http;
using System;

namespace BSWebtoon.Admin.Models.DTO.Activitys
{
    public class UpdateActivityDTO : Activity
    {

        //員工名稱
        public string ActivityEmployeeName { get; set; }
    }



}
