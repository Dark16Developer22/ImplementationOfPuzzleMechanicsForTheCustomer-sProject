using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Subconscionus.PuzzleMaze
{
    [RequireComponent(typeof(MoveWallMaze))]
    public class ChangeMazeController : MonoBehaviour
    {
        public TimerMaze TimerMazeS;
        public static List<ChangeMazeController> ChangeMazeControllers { get; set; } = new List<ChangeMazeController>();

        public enum OffsetWall
        {
            X, Y
        }
        /// <summary>
        /// ��� ������� ���� ������, ��� ������ ���������� ��������� ������� ����� � ������ ������, � ������� ���� � ���� ������� ����� X,Y,X,X,Y,Y,
        /// �� ���������� 7 ��������� ������� �� ��������� ����
        /// </summary>
        public OffsetWall[] OffsetWalls;
        /// <summary>
        /// �������� ��������� ������� �����
        /// </summary>
        public float SpeedOffsetWall;
        /// <summary>
        /// �� ������� ����� �������� ������� ����� ����� ��������� ���
        /// </summary>
        public float[] ValueOffsetPosition;

        public List<Vector3> ChangesPostionWall = new List<Vector3>();
        public Vector3 StartPosition;

        /// <summary>
        /// ���������� ���������� ��������� ���������
        /// </summary>
        public static int NoChangesLeftMaze { get; set; }
        /// <summary>
        /// ����� ���������� ��������� ���������
        /// </summary>
        public static int DefaultChangesLeftMaze { get; set; }

        private void Start()
        {
            ChangeMazeControllers.Add(this);
            StartPosition = transform.localPosition;
            if (OffsetWalls[0] == OffsetWall.X)
            {
                ChangesPostionWall.Add(new Vector2(transform.localPosition.x + ValueOffsetPosition[0], transform.localPosition.y));
            }
            else
            {
                ChangesPostionWall.Add(new Vector2(transform.localPosition.x, transform.localPosition.y + ValueOffsetPosition[0]));
            }
        }

        public void MazeStartPostion()
        {
            transform.localPosition = StartPosition;
        }
    }
}