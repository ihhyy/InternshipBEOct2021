﻿namespace BL.Interfaces
{
    public interface IValidator<T> where T : class
    {
        public void ValidateIfEntityExists(T value);
    }
}
