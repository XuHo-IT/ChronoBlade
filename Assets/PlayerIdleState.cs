public class PlayerIdleState : PlayerGroundedState
{
    public PlayerIdleState(Player player, PlayerStateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }
    public override void Update()
    {
        base.Update();

        if (xInput == player.facingDir && player.IsWallDetected())
        {

            stateMachine.ChangeState(player.idleState);
            return;
        }

        if (xInput != 0)
            stateMachine.ChangeState(player.moveState);
    }
    public override void Exit()
    {
        base.Exit();

    }

}
