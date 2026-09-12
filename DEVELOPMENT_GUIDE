# 📜 项目 C# 代码规范（Alpha）

> ⚠️ **警告**：本规范底稿为 DeepSeek 生成，请谨慎辨别。实际落地请以项目最终决策为准。

---

<details>
<summary>📁 点击展开/折叠：项目脚本目录结构</summary>

```text
Assets/
└── Scripts/
    │
    ├── Main/                                   // 【入口层】游戏总入口、全局管理与宏观流程调度
    │   ├── App.Main.asmdef                     // (允许引用 Modules, Core, Data, Utils)
    │   ├── Bootstrapper/                       // 启动器：按顺序初始化服务、加载首场景
    │   ├── GameManagers/                       // 全局管理器：场景加载、玩家数据、游戏状态
    │   └── Config/                             // 全局常量与游戏级配置（例如UI音效音量大小）
    │
    ├── Data/                                   // 【数据层】纯数据定义，无行为逻辑，无 MonoBehaviour
    │   ├── App.Data.asmdef                     // (仅允许引用 Utils)
    │   ├── Configs/                            // 静态配置数据（从 JSON 反序列化）
    │   │   ├── BaseItemConfig.cs               // 物品配置基类（原 InventoryBaseType）
    │   │   ├── Characters/                     // 角色配置（CharacterConfig 等）
    │   │   ├── Equipments/                     // 装备配置（HatConfig, ClothesConfig, WeaponConfig 等）
    │   │   ├── Languages/                      // 语言配置
    │   │   └── Emotes/                         // 表情配置（EmoteConfig 等）
    │   └── Runtime/                            // 运行时数据（PlayerAppearanceData 等）
    │
    ├── Core/                                   // 【核心层】底层能力与通用框架，与具体业务场景无关
    │   ├── App.Core.asmdef                     // (允许引用 Data, Utils, Spine 相关程序集)
    │   ├── Appearance/                         // 换装系统核心
    │   └── Services/                           // 跨场景通用服务（音频、存档、资源加载）
    │
    ├── Modules/                                // 【业务层】具体场景玩法，模块之间严禁互相引用
    │   ├── MainMenu/                           // 主界面模块
    │   │   ├── App.Modules.MainMenu.asmdef     // (允许引用 Core, Data, Utils)
    │   │   └── Controllers/                    // 主界面角色控制器等
    │   ├── Booth/                              // 角色照相厅模块
    │   │   ├── App.Modules.Booth.asmdef        // (允许引用 Core, Data, Utils)
    │   │   └── Controllers/                    // 照相厅角色控制器，照相厅舞台控制器之类的等
    │   └── Wardrobe/                           // 角色专用换装系统
    │       ├── App.Modules.Wardrobe.asmdef     // (允许引用 Core, Data, Utils)
    │       └── Controllers/                    // 换装系统角色控制器等
    │
    └── Utils/                                  // 【工具层】纯 C# 工具与数据结构，与游戏业务无关
        ├── App.Utils.asmdef                    // (无依赖)
        ├── Maths/                              // 数学与几何计算
        ├── Extensions/                         // 通用扩展方法
        └── Json/                               // JSON 解析辅助工具
```

</details>

---

## 一、 `Config` 类命名与映射规范（核心修改）

**规则**：所有位于 `Data/Configs/` 下的配置类，其**属性名必须与 JSON 字段名完全一致**（包括大小写）。**禁止使用 `[JsonProperty]` 进行重命名映射。**

### 标准写法

假设 JSON 数据为：

```json
{ "hideHair1": true, "spineSkin": "hat_01", "spineParts": [...] }
```

```csharp
// ✅ 推荐：属性名直接对齐 JSON 原生命名（camelCase）
public class HatConfig : BaseItemConfig
{
    public bool hideHair1 { get; private set; }
    public string spineSkin { get; private set; }
    public List<HatRuntimeSpinePart> spineParts { get; private set; } = new();
}
```

### 为何这样规定？

1. **消灭注解**：代码干净整洁，没有满屏的 `[JsonProperty]`，降低视觉噪音。
2. **所见即所得**：程序员看到 C# 属性，一眼就能知道它对应 JSON 里的哪个字段，无需反复跳转查看。
3. **重构无痛**：如果将来 JSON 字段改了名（比如 `hideHair1` 改成 `hideHair`），C# 属性直接跟着改即可，不需要同步修改注解，防止注解与属性名不一致的隐藏 Bug。

---

## 二、 属性封装与序列化兼容

虽然采用 camelCase 命名，但**依然必须遵守“自动属性 + 私有 Setter”**的封装原则，严禁使用公开字段。

```csharp
// ✅ 允许：自动属性 + 私有 Setter
public class HatConfig : BaseItemConfig
{
    public bool hideHair1 { get; private set; }
    public string spineSkin { get; private set; }
}
```

---

## 三、 永远不要向 Unity 暴露公开成员（保持不变）

**规则**：在 `MonoBehaviour` 和 `ScriptableObject` 中，**严禁使用 `public` 字段**来暴露数据给 Unity Inspector 或其他脚本。必须使用 `[SerializeField] private` 配合属性（Property）。

### 标准写法

```csharp
// ❌ 严禁：公开字段
public class SARCharacterController : MonoBehaviour
{
    public float moveSpeed;
    public GameObject arrow;
}

// ✅ 推荐：私有字段 + 序列化 + 属性
public class SARCharacterController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private GameObject _arrow;

    public float MoveSpeed => _moveSpeed;
    public GameObject Arrow => _arrow;
}
```

### 特殊场景：需要 Inspector 赋值但外部只读

```csharp
[field: SerializeField] public float MoveSpeed { get; private set; }
```

> ⚠️ **注意**：`[field: SerializeField]` 对某些老版本 Unity 或 IL2CPP 可能有兼容性问题，如果使用请务必在目标平台测试。

### 对于普通 C# 类（非 MonoBehaviour）

- 同样禁止 `public` 字段，必须使用属性。
- 如果该类不需要被 Unity 序列化，直接用 `public string itemID { get; private set; }` 即可。

---

## 五、 附加规范（修订版）

### 1. 集合初始化

`Config` 类中的 `List` 或 `Dictionary` 属性，必须在声明时或构造函数中初始化，**永远不要返回 `null`**：

```csharp
public List<HatRuntimeSpinePart> spineParts { get; private set; } = new();
```

### 2. `readonly struct` 优先

如果你的 `struct` 在创建后不需要修改字段，必须加 `readonly` 修饰符。

### 3. 大小写敏感警告

因为 C# 属性名直接对齐 JSON 原生命名，**请务必在代码审查时确认大小写完全一致**。

- JSON 里是 `"hideHair1"`，C# 属性必须写 `hideHair1`，不能写 `HideHair1` 或 `hidehair1`。
- 如果 Newtonsoft.Json 找不到匹配的属性，它会默认忽略该字段（不会报错），这会导致**数据静默丢失**。建议在反序列化测试阶段开启严格模式或打印未匹配的 JSON 字段。

---

## 六、 AI 本地自查清单（修订版）

当 AI 被要求生成或审查代码时，必须逐条检查：

- [ ] **Config 检查**：
  - [ ] 这个类是否位于 `Data/Configs/` 下？
  - [ ] 是否使用了自动属性？
  - [ ] 是否有 `public` 字段？（发现即报错）
  - [ ] **是否使用了 `[JsonProperty]`？如果是，报错并要求直接修改属性名对齐 JSON。**
  - [ ] **属性名是否与 JSON 字段名完全一致（包括大小写）？如果否，报错。**
- [ ] **Struct/Class 检查**：
  - [ ] 这个类型是否含有行为逻辑？如果是，必须是 `class`。
  - [ ] 这个类型是否是纯数据载体且体积小？如果是，必须是 `struct`。
  - [ ] 这个 `struct` 是否加了 `readonly`？如果没有，是否真的有修改需求？
- [ ] **Unity 暴露检查**：
  - [ ] 这个 `MonoBehaviour` / `ScriptableObject` 是否有 `public` 字段？如果是，必须改为 `[SerializeField] private` + 属性。
  - [ ] 这个普通 C# 类是否有 `public` 字段？如果是，必须改为属性。
- [ ] **集合检查**：`Config` 中的集合属性是否已初始化？是否有可能返回 `null`？

---

## 七、 开发组协作要求

1. **代码审查（PR Review）**：如果 PR 中出现了违反上述三条核心规范（Config 公开字段、`[JsonProperty]` 映射、Struct/Class 混用、Unity 公开成员）的代码，**直接打回，不允许合并**。
2. **重构优先级**：在重构现有代码时，优先处理 `Data/Configs/` 下的类，因为它们是最基础的数据层，影响面最广。
3. **文档同步**：这份规范应写入项目 Wiki，并作为新成员入职培训的第一课。
4. **AI 辅助开发 (Vibe Coding)**: 项目允许使用AI，并且推荐使用AI开发，但是需要在某个模块完成之后需要进行代码审查才允许提交。

---