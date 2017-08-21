using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessPiece : MonoBehaviour
{
    public bool isWhite;
    public bool isPawn;
    public bool isRook;
    public bool isKnight;
    public bool isBishop;
    public bool isKing;
    public bool isQueen;

    public GameObject tileSelecter;

    float currentX;
    float currentZ;
    int selectHeight = 7;

    void OnMouseDown()
    {
        Vector3 position = gameObject.transform.position;
        currentX = position.x;
        currentZ = position.z;

        if (isPawn == true)
        {
            pawnMove();
        }
        if (isRook == true)
        {
            rookMove();
        }
        if (isKnight == true)
        {
            knightMove();
        }
        if (isBishop == true)
        {
            bishopMove();
        }
        if (isKing == true)
        {
            kingMove();
        }
        if (isQueen == true)
        {
            queenMove();
        }

        Debug.Log(currentX);
        Debug.Log(currentZ);
    }

    void pawnMove()
    {
        float xPosAvailable = currentX + 7;
        Instantiate(tileSelecter, new Vector3(xPosAvailable, selectHeight, currentZ), Quaternion.identity);
    }

    void rookMove()
    {
        rookVertical1();
        rookVertical2();
        rookHorizontal1();
        rookHorizontal2();
    }

    void knightMove()
    {
        float pos1X = currentX + 14; float pos1Z = currentZ + 7;
        float pos2X = currentX + 14; float pos2Z = currentZ - 7;
        float pos3X = currentX + 7; float  pos3Z = currentZ - 14;
        float pos4X = currentX - 7; float  pos4Z = currentZ - 14;
        float pos5X = currentX - 14; float pos5Z = currentZ + 7;
        float pos6X = currentX - 14; float pos6Z = currentZ - 7;
        float pos7X = currentX + 7; float  pos7Z = currentZ + 14;
        float pos8X = currentX - 7; float  pos8Z = currentZ + 14;
        Instantiate(tileSelecter, new Vector3(pos1X, selectHeight, pos1Z), Quaternion.identity);
        Instantiate(tileSelecter, new Vector3(pos2X, selectHeight, pos2Z), Quaternion.identity);
        Instantiate(tileSelecter, new Vector3(pos3X, selectHeight, pos3Z), Quaternion.identity);
        Instantiate(tileSelecter, new Vector3(pos4X, selectHeight, pos4Z), Quaternion.identity);
        Instantiate(tileSelecter, new Vector3(pos5X, selectHeight, pos5Z), Quaternion.identity);
        Instantiate(tileSelecter, new Vector3(pos6X, selectHeight, pos6Z), Quaternion.identity);
        Instantiate(tileSelecter, new Vector3(pos7X, selectHeight, pos7Z), Quaternion.identity);
        Instantiate(tileSelecter, new Vector3(pos8X, selectHeight, pos8Z), Quaternion.identity);
    }

    void bishopMove()
    {
        bishopMove1();
        bishopMove2();
        bishopMove3();
        bishopMove4();
    }

    void kingMove()
    {
        float pos1X = currentX + 7; float pos1Z = currentZ + 7;
        float pos2X = currentX + 7; float pos2Z = currentZ;
        float pos3X = currentX + 7; float pos3Z = currentZ - 7;
        float pos4X = currentX;     float pos4Z = currentZ - 7;
        float pos5X = currentX - 7; float pos5Z = currentZ - 7;
        float pos6X = currentX - 7; float pos6Z = currentZ;
        float pos7X = currentX - 7; float pos7Z = currentZ + 7;
        float pos8X = currentX;     float pos8Z = currentZ + 7;
        Instantiate(tileSelecter, new Vector3(pos1X, selectHeight, pos1Z), Quaternion.identity);
        Instantiate(tileSelecter, new Vector3(pos2X, selectHeight, pos2Z), Quaternion.identity);
        Instantiate(tileSelecter, new Vector3(pos3X, selectHeight, pos3Z), Quaternion.identity);
        Instantiate(tileSelecter, new Vector3(pos4X, selectHeight, pos4Z), Quaternion.identity);
        Instantiate(tileSelecter, new Vector3(pos5X, selectHeight, pos5Z), Quaternion.identity);
        Instantiate(tileSelecter, new Vector3(pos6X, selectHeight, pos6Z), Quaternion.identity);
        Instantiate(tileSelecter, new Vector3(pos7X, selectHeight, pos7Z), Quaternion.identity);
        Instantiate(tileSelecter, new Vector3(pos8X, selectHeight, pos8Z), Quaternion.identity);
    }

    void queenMove()
    {
        rookVertical1();
        rookVertical2();
        rookHorizontal1();
        rookHorizontal2();
        bishopMove1();
        bishopMove2();
        bishopMove3();
        bishopMove4();
    }

    void rookVertical1()
    {
        int amount = 7;
        int done = 0;
        float xPosAvailable = currentX + 7;
        while (amount > done)
        {
            if (isWhite == true)
            {
                Instantiate(tileSelecter, new Vector3(xPosAvailable, selectHeight, currentZ), Quaternion.identity);
                xPosAvailable = xPosAvailable + 7;
                done++;
            }
        }
    }
    void rookVertical2()
    {
        int amount = 7;
        int done = 0;
        float xPosAvailable = currentX - 7;
        while (amount > done)
        {
            if (isWhite == true)
            {
                Instantiate(tileSelecter, new Vector3(xPosAvailable, selectHeight, currentZ), Quaternion.identity);
                xPosAvailable = xPosAvailable - 7;
                done++;
            }
        }
    }
    void rookHorizontal1()
    {
        int amount = 7;
        int done = 0;
        float zPosAvailable = currentZ - 7;
        while (amount > done)
        {
            if (isWhite == true)
            {
                Instantiate(tileSelecter, new Vector3(currentX, selectHeight, zPosAvailable), Quaternion.identity);
                zPosAvailable = zPosAvailable - 7;
                done++;
            }
        }
    }
    void rookHorizontal2()
    {
        int amount = 7;
        int done = 0;
        float zPosAvailable = currentZ + 7;
        while (amount > done)
        {
            if (isWhite == true)
            {
                Instantiate(tileSelecter, new Vector3(currentX, selectHeight, zPosAvailable), Quaternion.identity);
                zPosAvailable = zPosAvailable + 7;
                done++;
            }
        }
    }
    void bishopMove1()
    {
        int amount = 7;
        int done = 0;
        float xPosAvailable = currentX + 7;
        float zPosAvailable = currentZ + 7;
        while (amount > done)
        {
            if (isWhite == true)
            {
                Instantiate(tileSelecter, new Vector3(xPosAvailable, selectHeight, zPosAvailable), Quaternion.identity);
                xPosAvailable = xPosAvailable + 7;
                zPosAvailable = zPosAvailable + 7;
                done++;
            }
        }
    }
    void bishopMove2()
    {
        int amount = 7;
        int done = 0;
        float xPosAvailable = currentX - 7;
        float zPosAvailable = currentZ - 7;
        while (amount > done)
        {
            if (isWhite == true)
            {
                Instantiate(tileSelecter, new Vector3(xPosAvailable, selectHeight, zPosAvailable), Quaternion.identity);
                xPosAvailable = xPosAvailable - 7;
                zPosAvailable = zPosAvailable - 7;
                done++;
            }
        }
    }
    void bishopMove3()
    {
        int amount = 7;
        int done = 0;
        float xPosAvailable = currentX - 7;
        float zPosAvailable = currentZ + 7;
        while (amount > done)
        {
            if (isWhite == true)
            {
                Instantiate(tileSelecter, new Vector3(xPosAvailable, selectHeight, zPosAvailable), Quaternion.identity);
                xPosAvailable = xPosAvailable - 7;
                zPosAvailable = zPosAvailable + 7;
                done++;
            }
        }
    }
    void bishopMove4()
    {
        int amount = 7;
        int done = 0;
        float xPosAvailable = currentX + 7;
        float zPosAvailable = currentZ - 7;
        while (amount > done)
        {
            if (isWhite == true)
            {
                Instantiate(tileSelecter, new Vector3(xPosAvailable, selectHeight, zPosAvailable), Quaternion.identity);
                xPosAvailable = xPosAvailable + 7;
                zPosAvailable = zPosAvailable - 7;
                done++;
            }
        }
    }
}
