﻿using System.Collections.Generic;

namespace BL.DTOs
{
    public class UserDTO
	{
		public string Id { get; set; }

		public string Position { get; set; }

		public string Email { get; set; }

		public string PhoneNumber { get; set; }

		public string UserName { get; set; }

        public string RoleType { get; set; }

		public List<FeedbackDTO> Feedbacks { get; set; }
    }
}
