///
/// INFORMATION
/// 
/// Project: Adding Comments
/// Game: Example
/// Date: 10/11/2020
/// Author: Nekroarteriaa Games
/// Website: https://nekroarteriaa.itch.io
/// Programmers: Olaf Gomez.
/// Description: Class of the #Player

using UnityEngine;


/// <summary>
/// Class of the #Player
/// </summary>
public class Player: MonoBehaviour
{ 
    /// <summary>
    /// Player's name
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Player's id number
    /// </summary>
    public int Id { get; private set; }
}
