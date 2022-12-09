﻿namespace Domain.Models;

public class BaseEntity<T>
{
    public T Id { get; set; }

    public bool IsDelete { get; set; }=false;
    public DateTime CreateDate { get; set; }=DateTime.Now;

}