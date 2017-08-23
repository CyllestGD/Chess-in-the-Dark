using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoardManager : MonoBehaviour
{
    public ChessPiece[,] ChessPieces { set; get; }
    private ChessPiece selectedPiece;

    private float pawnPos = -24.5f;

    private float blackBackXPos = 24.5f;
    private float blackFwdXPos = 17.5f;
    private float whiteBackXPos = -24.5f;
    private float whiteFwdXPos = -17.5f;
    private int pieceHeight = 7;

    private float currentRow = 24.5f;
    private float currentColumn = 24.5f;

    public Transform fog;

    public List<GameObject> chessPiecePrefabs;
    private List<GameObject> activeChessPieces;

    public bool isWhiteTurn = true;

    private void Start()
    {
        SpawnAllPieces();
        PlaceholderFogSpawner();
    }

    private void Update()
    {

    }

    private void SpawnChessPiece(int index, Vector3 position)
    {
        GameObject go = Instantiate(chessPiecePrefabs[index], position, chessPiecePrefabs[index].transform.rotation) as GameObject;
        go.transform.SetParent(transform);
        activeChessPieces.Add(go);
    }

    private void SpawnAllPieces()
    {
        activeChessPieces = new List<GameObject>();

        // Spawn Black Pieces
        SpawnChessPiece(4, new Vector3(blackBackXPos, pieceHeight, -24.5f));
        SpawnChessPiece(3, new Vector3(blackBackXPos, pieceHeight, -17.5f));
        SpawnChessPiece(2, new Vector3(blackBackXPos, pieceHeight, -10.5f));
        SpawnChessPiece(1, new Vector3(blackBackXPos, pieceHeight, -3.5f));
        SpawnChessPiece(0, new Vector3(blackBackXPos, pieceHeight, 3.5f));
        SpawnChessPiece(2, new Vector3(blackBackXPos, pieceHeight, 10.5f));
        SpawnChessPiece(3, new Vector3(blackBackXPos, pieceHeight, 17.5f));
        SpawnChessPiece(4, new Vector3(blackBackXPos, pieceHeight, 24.5f));
        
        // Spawn White Pieces
        SpawnChessPiece(10, new Vector3(whiteBackXPos, pieceHeight, -24.5f));
        SpawnChessPiece(9,  new Vector3(whiteBackXPos, pieceHeight, -17.5f));
        SpawnChessPiece(8,  new Vector3(whiteBackXPos, pieceHeight, -10.5f));
        SpawnChessPiece(7,  new Vector3(whiteBackXPos, pieceHeight, -3.5f));
        SpawnChessPiece(6,  new Vector3(whiteBackXPos, pieceHeight, 3.5f));
        SpawnChessPiece(8,  new Vector3(whiteBackXPos, pieceHeight, 10.5f));
        SpawnChessPiece(9,  new Vector3(whiteBackXPos, pieceHeight, 17.5f));
        SpawnChessPiece(10, new Vector3(whiteBackXPos, pieceHeight, 24.5f));

        // Spawn Pawns 
        for (int pawnNum = 0; pawnNum < 8; pawnNum++)
        {
            SpawnChessPiece(5,  new Vector3(blackFwdXPos, pieceHeight, pawnPos));
            SpawnChessPiece(11, new Vector3(whiteFwdXPos, pieceHeight, pawnPos));
            pawnPos = pawnPos + 7;
        }
    }

    private void PlaceholderFogSpawner()
    {
        for (int rowNum = 0; rowNum < 8; rowNum++)
        {
            for (int columnNum = 0; columnNum < 8; columnNum++)
            {
                Instantiate(fog, new Vector3(currentRow, pieceHeight, currentColumn), Quaternion.Euler(0, 0, 0));
                currentColumn = currentColumn - 7;
            }
            currentColumn = 24.5f;
            currentRow = currentRow - 7;
        }
    }
    
}
