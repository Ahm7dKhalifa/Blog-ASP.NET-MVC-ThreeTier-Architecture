﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogModel
{
	public class BlogComment
	{
		[Key]
		public int CommmentID { get; set; }//评论唯一标识

		[Required]
		public int TextID { get; set; }//评论所在文章

		[Required]
		public string Account { get; set; }//发布人

		[Required]
		[MaxLength(100)]
		public string CommentText { get; set; }//内容

		[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public DateTime CommentChangeDate { get; set; }//更新日期

		public virtual BlogUser User { get; set; }
		public virtual BlogText Text { get; set; }
	}
}
