﻿namespace Assistant.Web;

public interface IProblemDetailsConverter
{
    ProblemDetails Convert(Stream stream);
}