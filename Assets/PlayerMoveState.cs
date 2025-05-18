public class PlayerMoveState : PlayerGroundedState
{
    public PlayerMoveState(Player player, PlayerStateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }
    public override void Update()
    {

        base.Update();
        if (player.IsWallDetected() && xInput == player.facingDir)
        {
            player.SetVelocity(0f, rb.velocity.y);
            stateMachine.ChangeState(player.idleState);
            return;
        }

        player.SetVelocity(xInput * player.moveSpeed, rb.velocity.y);


        if (xInput == 0)
            stateMachine.ChangeState(player.idleState);
    }
    public override void Exit()
    {
        base.Exit();
    }
}
