﻿using App.Infrastructure;

namespace App.Controllers.Abstractions
{
    public interface IAnalyzerModel
    {
        /// <summary>
        /// Выполнить обработку кода
        /// </summary>
        /// <param name="code">Код</param>
        /// <returns>Результат обработки</returns>
        AnalyzerResult Execute(string code);
    }
}