﻿

namespace Domains.Models;

public class CategoryDto
{

    public int CategoryId { get; set; }

    public string CategoryName { get; set; }=string.Empty;

    public override string ToString()
    {
        return $"CategoryId:{CategoryId}, CategoryName:{CategoryName}";
    }

}

