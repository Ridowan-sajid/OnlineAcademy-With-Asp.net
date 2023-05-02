﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CommentDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime Date { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }
        /*public virtual Student Student { get; set; }*/

        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        /*public virtual Teacher Teacher { get; set; }*/


        [ForeignKey("Post")]
        public int PostId { get; set; }
        /*public virtual Post Post { get; set; }*/


    }
}