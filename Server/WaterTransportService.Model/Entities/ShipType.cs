using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WaterTransportService.Model.Entities;

/// <summary>
/// ���������� ����� �����.
/// </summary>
[Table("ship_types")]
public class ShipType
{
    /// <summary>
    /// ������������� ���� �����.
    /// </summary>
    [Key]
    [Column("id")]
    public required ushort Id { get; set; }

    /// <summary>
    /// �������� ���� �����.
    /// </summary>
    [Required]
    [MaxLength(32)]
    [Column("name")]
    public required string Name { get; set; }

    /// <summary>
    /// �������� ���� ����� (�����������).
    /// </summary>
    [MaxLength(1000)]
    [Column("description")]
    public string? Description { get; set; }

    /// <summary>
    /// ������ ����� ������� ����.
    /// </summary>
    public ICollection<Ship> Ships { get; set; } = [];
}