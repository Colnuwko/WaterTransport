﻿namespace WaterTransportService.Model.Entities;

/// <summary>
/// Базовая сущность, содержащая общие поля для всех моделей.
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    /// Время создания записи в UTC.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Время последнего обновления записи в UTC.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }
}