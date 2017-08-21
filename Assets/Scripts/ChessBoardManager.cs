using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoardManager : MonoBehaviour
{
    public ChessPiece[,] ChessPieces { set; get; }
    private ChessPiece selectedPiece;

    private float blackBackXPos = 24.5f;
    private float blackFwdXPos = 17.5f;
    private float whiteBackXPos = -24.5f;
    private float whiteFwdXPos = -17.5f;
    private int pieceHeight = 7;

    private float row1 = 24.5f;
    private float row2 = 17.5f;
    private float row3 = 10.5f;
    private float row4 = 3.5f;
    private float row5 = -3.5f;
    private float row6 = -10.5f;
    private float row7 = -17.5f;
    private float row8 = -24.5f;
    private float column1 = 24.5f;
    private float column2 = 17.5f;
    private float column3 = 10.5f;
    private float column4 = 3.5f;
    private float column5 = -3.5f;
    private float column6 = -10.5f;
    private float column7 = -17.5f;
    private float column8 = -24.5f;

    public Transform fog;

    public List<GameObject> chessPiecePrefabs;
    private List<GameObject> activeChessPieces;

    public bool isWhiteTurn = true;

    private void Start()
    {
        SpawnAllPieces();
        //PlaceholderFogSpawner();
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

    /*private void PlaceholderFogSpawner() //DONT OPEN
    {
        Instantiate(fog, new Vector3(row1, pieceHeight, column1), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row1, pieceHeight, column2), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row1, pieceHeight, column3), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row1, pieceHeight, column4), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row1, pieceHeight, column5), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row1, pieceHeight, column6), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row1, pieceHeight, column7), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row1, pieceHeight, column8), Quaternion.Euler(0, 0, 0));


        Instantiate(fog, new Vector3(row2, pieceHeight, column1), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row2, pieceHeight, column2), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row2, pieceHeight, column3), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row2, pieceHeight, column4), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row2, pieceHeight, column5), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row2, pieceHeight, column6), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row2, pieceHeight, column7), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row2, pieceHeight, column8), Quaternion.Euler(0, 0, 0));


        Instantiate(fog, new Vector3(row3, pieceHeight, column1), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row3, pieceHeight, column2), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row3, pieceHeight, column3), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row3, pieceHeight, column4), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row3, pieceHeight, column5), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row3, pieceHeight, column6), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row3, pieceHeight, column7), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row3, pieceHeight, column8), Quaternion.Euler(0, 0, 0));


        Instantiate(fog, new Vector3(row4, pieceHeight, column1), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row4, pieceHeight, column2), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row4, pieceHeight, column3), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row4, pieceHeight, column4), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row4, pieceHeight, column5), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row4, pieceHeight, column6), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row4, pieceHeight, column7), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row4, pieceHeight, column8), Quaternion.Euler(0, 0, 0));


        Instantiate(fog, new Vector3(row5, pieceHeight, column1), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row5, pieceHeight, column2), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row5, pieceHeight, column3), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row5, pieceHeight, column4), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row5, pieceHeight, column5), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row5, pieceHeight, column6), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row5, pieceHeight, column7), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row5, pieceHeight, column8), Quaternion.Euler(0, 0, 0));


        Instantiate(fog, new Vector3(row6, pieceHeight, column1), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row6, pieceHeight, column2), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row6, pieceHeight, column3), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row6, pieceHeight, column4), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row6, pieceHeight, column5), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row6, pieceHeight, column6), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row6, pieceHeight, column7), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row6, pieceHeight, column8), Quaternion.Euler(0, 0, 0));


        Instantiate(fog, new Vector3(row7, pieceHeight, column1), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row7, pieceHeight, column2), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row7, pieceHeight, column3), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row7, pieceHeight, column4), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row7, pieceHeight, column5), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row7, pieceHeight, column6), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row7, pieceHeight, column7), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row7, pieceHeight, column8), Quaternion.Euler(0, 0, 0));


        Instantiate(fog, new Vector3(row8, pieceHeight, column1), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row8, pieceHeight, column2), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row8, pieceHeight, column3), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row8, pieceHeight, column4), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row8, pieceHeight, column5), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row8, pieceHeight, column6), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row8, pieceHeight, column7), Quaternion.Euler(0, 0, 0));
        Instantiate(fog, new Vector3(row8, pieceHeight, column8), Quaternion.Euler(0, 0, 0));
    }
    */
}
