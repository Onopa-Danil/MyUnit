using System;
using SystemArithmetic.Tests;
using MyUnit;

var typeInfo = typeof(SumTest);

TestRunner.OnTestFailure += (name, message) => Console.WriteLine($"Тест не пройден: " +
    $"{name}{(string.IsNullOrWhiteSpace(message) ? string.Empty : $". Сообщение: {message}")}"); 
TestRunner.OnTestPass += (name, message) => Console.WriteLine($"Тесты в классе " +
    $"{name} пройдены успешно.{(string.IsNullOrWhiteSpace(message) ? string.Empty : $" Сообщение: {message}")}"); 

TestRunner.Run(typeInfo);
