﻿namespace API.Enteties;

public class AppUser
{
  public int Id { get; set; } //"Id" always must be set as written down.
  public required string UserName { get; set; } //"UserName" always must be set as written down.
}
  // Id and UserName names can be changed using key array
  // '?' meaning is we may set username or Not.
