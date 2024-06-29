using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch4.Api.FitnessTracker.DataAccess.Models;

[Table("Tbl_User")]
public class User
{
    
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Password { get; set; }
}
