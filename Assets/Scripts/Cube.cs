using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Form
{
    override protected float moveSpeed { get { return 1; } }
    override protected float rotateSpeed { get { return 1; } }
    override protected float jumpSpeed { get { return 1; } }
}
