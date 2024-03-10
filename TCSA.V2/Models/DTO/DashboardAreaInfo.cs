﻿using Microsoft.Identity.Client;

namespace TCSA.V2.Models;

public class DashboardAreaInfo
{
    public Area Area { get; set; }
    public string Description { get; set; }
    public string ImgUrl { get; set; }

    public bool IsCompleted {  get; set; }
    public string CardName { get; set; }

    public List<Project> Projects { get; set; }
}
