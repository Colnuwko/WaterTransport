namespace WaterTransportService.Model.Entities;

/// <summary>
/// ���������� ����� �����.
/// </summary>
public class ShipType
{
    /// <summary>
    /// ������������� ���� �����.
    /// </summary>
    public required ushort Id { get; set; }

    /// <summary>
    /// �������� ���� �����.
    /// </summary>
    public required string Name { get; set; }
}