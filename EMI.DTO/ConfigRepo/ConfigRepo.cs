using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMI.DTO.ConfigRepo;

public static class ConfigRepo
{
    public static string ReadConection { get; set; } = "no value has been set";
    public static string WriteConnection { get; set; } = "no value has been set";
}

