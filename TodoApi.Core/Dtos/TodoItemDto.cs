﻿namespace TodoApi.Core.Dtos
{
	public class TodoItemDto
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public bool IsComplete { get; set; }
	}
}
