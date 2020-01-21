//-------------------------------------------------------------------------------------
//	C#抽象工厂模式例子
//-------------------------------------------------------------------------------------

using UnityEngine;

namespace Example_3
{
    public class AbstractFactoryPatternExample : MonoBehaviour
    {
        void Start()
        {
            EnemyShipBuilding ufoBuilder = new UFOEnemyShipBuilding();
            ufoBuilder.orderShip(ShipType.UFO);
        }
    }

//-------------------------------------------------------------------------------------
//	总部
//-------------------------------------------------------------------------------------
    public enum ShipType
    {
        UFO
    }

    public abstract class EnemyShipBuilding
    {
        protected abstract EnemyShip MakeEnemyShip(ShipType type);

        public EnemyShip orderShip(ShipType type)
        {
            EnemyShip ship = MakeEnemyShip(type);

            ship.MakeShip();
            ship.DisplayShip();
            ship.FollowHeroShip();
            ship.Shoot();

            return ship;
        }
    }

    public class UFOEnemyShipBuilding : EnemyShipBuilding
    {
        protected override EnemyShip MakeEnemyShip(ShipType type)
        {
            EnemyShip ship = null;

            if (type == ShipType.UFO)
            {
                IEnemyShipFactory factory = new UFOEnemyShipFactory();
                ship = new UFOEnemyShip(factory);
                ship.name = "UFO";
            }

            return ship;
        }
    }

//-------------------------------------------------------------------------------------
//	飞船
//-------------------------------------------------------------------------------------
    public abstract class EnemyShip
    {
        public string name;
        protected IESEngine engine;
        protected IESWeapon weapon;

        public abstract void MakeShip();

        public void DisplayShip()
        {
            Debug.Log(name + " is on the screen.");
        }

        public void FollowHeroShip()
        {
            Debug.Log(name + " follows hero ship with " + engine.ToStringEX());
        }

        public void Shoot()
        {
            Debug.Log(name + " shoots and does " + weapon.ToStringEX());
        }

        public string ToStringEX()
        {
            return "The " + name + " has a speed of " + engine.ToStringEX() + " a firepower of " + weapon.ToStringEX();
        }
    }

    public class UFOEnemyShip : EnemyShip
    {
        IEnemyShipFactory factory;

        public UFOEnemyShip(IEnemyShipFactory factory)
        {
            this.factory = factory;
        }

        public override void MakeShip()
        {
            Debug.Log("Making enemy ship " + name);
            weapon = factory.AddESGun();
            engine = factory.AddESEngine();
        }
    }

//-------------------------------------------------------------------------------------
//	造船厂
//-------------------------------------------------------------------------------------
    public interface IEnemyShipFactory
    {
        IESWeapon AddESGun();
        IESEngine AddESEngine();
    }

    public class UFOEnemyShipFactory : IEnemyShipFactory
    {
        public IESWeapon AddESGun()
        {
            return new ESUFOGun();
        }

        public IESEngine AddESEngine()
        {
            return new ESUFOEngine();
        }
    }

//-------------------------------------------------------------------------------------
//	飞船零件
//-------------------------------------------------------------------------------------
    public interface IESWeapon
    {
        string ToStringEX();
    }

    public interface IESEngine
    {
        string ToStringEX();
    }

    public class ESUFOGun : IESWeapon
    {
        public string ToStringEX()
        {
            return "20 damage";
        }
    }
    public class ESUFOEngine : IESEngine
    {
        public string ToStringEX()
        {
            return "1000 mph";
        }
    }
}

