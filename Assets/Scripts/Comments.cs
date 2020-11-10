///
/// INFORMATION
/// 
/// Project: Adding Comments
/// Game: Example
/// Date: 10/11/2020
/// Author: Nekroarteriaa Games
/// Website: https://nekroarteriaa.itch.io
/// Programmers: Olaf Gomez.
/// Description: Class of the player Manager

using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class of the player manager
/// </summary>
public class Comments : MonoBehaviour
{
    /// <summary>
    /// Event triggered when a player is added to the player list
    /// </summary>
    public event Action<Player> PlayerAdded = delegate { };

    /// <summary>
    /// Event triggered when a player is removed from the player list
    /// </summary>
    public event Action<Player> PlayerRemoved = delegate { };

    /// <summary>
    /// List of players on scene
    /// </summary>
    private List<Player> _players;

    private void Awake()
    {
        _players = new List<Player>();
    }

    /// <summary>
    /// Get a player be his id from player list
    /// </summary>
    /// <param name="id">The desired player id</param>
    /// <returns>Returns the founded player in player list</returns>
    public Player GetPlayerById(int id)
    {
        return _players.Find(player => player.Id == id);
    }

    /// <summary>
    /// Adds a player to player list
    /// </summary>
    /// <param name="player">The player that is going to be added inside the player list</param>
    public void AddPlayer(Player player)
    {
        _players.Add(player);

        OnPlayerAdded(player);
    }

    /// <summary>
    /// Removes a player from player list
    /// </summary>
    /// <param name="player">The player that is going to be removed from the player list</param>
    public void RemovePlayer(Player player)
    {
        _players.Remove(player);

        OnPlayerRemoved(player);
    }

    /// <summary>
    /// Gets the position of a player inside the player list
    /// </summary>
    /// <param name="id">The desired player id</param>
    /// <returns>Returns the position of the matched player id in the player list</returns>
    public Vector3 GetPlayerPositionById(int id)
    {
        return GetPlayerById(id).transform.position;
    }

    /// <summary>
    /// Triggers the #PlayerAdded event when a player has been added to the player list
    /// </summary>
    /// <param name="player">The added player</param>
    public void OnPlayerAdded(Player player)
    {
        if(PlayerAdded != null)
        {
            PlayerAdded.Invoke(player);
        }
    }

    /// <summary>
    /// Triggers the #PlayerRemoved event when a player has been removed from the player list
    /// </summary>
    /// <param name="player"></param>
    public void OnPlayerRemoved(Player player)
    {
        if (PlayerAdded != null)
        {
            PlayerRemoved.Invoke(player);
        }
    }
}
