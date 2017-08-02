using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoardManager : MonoBehaviour
{
    public ChessPiece[,] ChessPieces { set; get; }
    private ChessPiece selectedPiece;

    private const float tileSize = 7.0f;
    private const float tileOffset = 0.5f;

    private int selectionX = -1;
    private int selectionY = -1;

    private float blackBackXPos = 24.5f;
    private float blackFwdXPos = 17.5f;
    private float whiteBackXPos = -24.5f;
    private float whiteFwdXPos = -17.5f;
    private int pieceHeight = 7;

    public List<GameObject> chessPiecePrefabs;
    private List<GameObject> activeChessPieces;

    private void Start()
    {
        SpawnAllPieces();
    }

    private void Update()
    {
        //DrawChessboard();
        //UpdateSelection();
    }

    private void UpdateIndex()
    {

    }

    private void SpawnChessPiece(int index, Vector3 position)
    {
        GameObject go = Instantiate(chessPiecePrefabs[index], position, chessPiecePrefabs[index].transform.rotation) as GameObject;
        go.transform.SetParent(transform);
        ChessPieces[x, y] = go.GetComponent<ChessPiece>();
        activeChessPieces.Add(go);
    }

    private void SpawnAllPieces()
    {
        activeChessPieces = new List<GameObject>();

        // Spawn Black Pieces
            // Back Row
            SpawnChessPiece(4, new Vector3(blackBackXPos, pieceHeight, -24.5f));
            SpawnChessPiece(3, new Vector3(blackBackXPos, pieceHeight, -17.5f));
            SpawnChessPiece(2, new Vector3(blackBackXPos, pieceHeight, -10.5f));
            SpawnChessPiece(1, new Vector3(blackBackXPos, pieceHeight, -3.5f));
            SpawnChessPiece(0, new Vector3(blackBackXPos, pieceHeight, 3.5f));
            SpawnChessPiece(2, new Vector3(blackBackXPos, pieceHeight, 10.5f));
            SpawnChessPiece(3, new Vector3(blackBackXPos, pieceHeight, 17.5f));
            SpawnChessPiece(4, new Vector3(blackBackXPos, pieceHeight, 24.5f));
            // Front Row
            SpawnChessPiece(5, new Vector3(blackFwdXPos, pieceHeight, -24.5f));
            SpawnChessPiece(5, new Vector3(blackFwdXPos, pieceHeight, -17.5f));
            SpawnChessPiece(5, new Vector3(blackFwdXPos, pieceHeight, -10.5f));
            SpawnChessPiece(5, new Vector3(blackFwdXPos, pieceHeight, -3.5f));
            SpawnChessPiece(5, new Vector3(blackFwdXPos, pieceHeight, 3.5f));
            SpawnChessPiece(5, new Vector3(blackFwdXPos, pieceHeight, 10.5f));
            SpawnChessPiece(5, new Vector3(blackFwdXPos, pieceHeight, 17.5f));
            SpawnChessPiece(5, new Vector3(blackFwdXPos, pieceHeight, 24.5f));
        
        // Spawn White Pieces
            // Back Row
            SpawnChessPiece(10, new Vector3(whiteBackXPos, pieceHeight, -24.5f));
            SpawnChessPiece(9, new Vector3(whiteBackXPos, pieceHeight, -17.5f));
            SpawnChessPiece(8, new Vector3(whiteBackXPos, pieceHeight, -10.5f));
            SpawnChessPiece(7, new Vector3(whiteBackXPos, pieceHeight, -3.5f));
            SpawnChessPiece(6, new Vector3(whiteBackXPos, pieceHeight, 3.5f));
            SpawnChessPiece(8, new Vector3(whiteBackXPos, pieceHeight, 10.5f));
            SpawnChessPiece(9, new Vector3(whiteBackXPos, pieceHeight, 17.5f));
            SpawnChessPiece(10, new Vector3(whiteBackXPos, pieceHeight, 24.5f));
            // Front Row
            SpawnChessPiece(11, new Vector3(whiteFwdXPos, pieceHeight, -24.5f));
            SpawnChessPiece(11, new Vector3(whiteFwdXPos, pieceHeight, -17.5f));
            SpawnChessPiece(11, new Vector3(whiteFwdXPos, pieceHeight, -10.5f));
            SpawnChessPiece(11, new Vector3(whiteFwdXPos, pieceHeight, -3.5f));
            SpawnChessPiece(11, new Vector3(whiteFwdXPos, pieceHeight, 3.5f));
            SpawnChessPiece(11, new Vector3(whiteFwdXPos, pieceHeight, 10.5f));
            SpawnChessPiece(11, new Vector3(whiteFwdXPos, pieceHeight, 17.5f));
            SpawnChessPiece(11, new Vector3(whiteFwdXPos, pieceHeight, 24.5f));
    }

    /*private void UpdateSelection()
    {
        if (!Camera.main)
            return;

        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 25.0f, LayerMask.GetMask("ChessPlane")))
        {
            selectionX = (int)hit.point.x;
            selectionY = (int)hit.point.y;
        }
        else
        {
            selectionX = -1;
            selectionY = -1;
        }
    }*/

    /*private void DrawChessboard()
    {
        Vector3 widthLine = Vector3.right * 8;
        Vector3 heightLine = Vector3.forward * 8;

        for (int i = 0; i <= 8; i++)
        {
            Vector3 start = Vector3.forward * i;
            Debug.DrawLine(start, start + widthLine);

            start = Vector3.right * i;
            Debug.DrawLine(start, start + heightLine);
        }

        // Draw the selection
        if (selectionX >= 0 && selectionY >= 0)
        {
            Debug.DrawLine(
                Vector3.forward * selectionY + Vector3.right * selectionX,
                Vector3.forward * (selectionY + 1) + Vector3.right * (selectionX + 1));

            Debug.DrawLine(
                Vector3.forward * (selectionY + 1) + Vector3.right * selectionX,
                Vector3.forward * selectionY + Vector3.right * (selectionX + 1));
        }
    }*/
}
