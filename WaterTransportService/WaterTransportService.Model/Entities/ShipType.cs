using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WaterTransportService.Model.Entities;

/// <summary>
/// ���������� ����� �����.
/// </summary>
public class ShipType
{
    /// <summary>
    /// ������������� ���� �����.
    /// </summary>
    [Key]
    public required ushort Id { get; set; }

    /// <summary>
    /// �������� ���� �����.
    /// </summary>
    [Required]
    [MaxLength(256)]
    public required string Name { get; set; }

    /// <summary>
    /// �������� ���� ����� (�����������).
    /// </summary>
    [MaxLength(1000)]
    public string? Description { get; set; }
}