# Class InteractorActionPublisherFacade

The public interface into the Interactor Action Publisher Prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [ActiveAction]
  * [Configuration]
  * [PublisherIdentifier]
  * [SourceAction]
  * [SourceInteractor]
* [Methods]
  * [ClearPublisherIdentifier()]
  * [ClearSourceAction()]
  * [ClearSourceInteractor()]
  * [OnAfterPublisherIdentifierChange()]
  * [OnAfterSourceActionChange()]
  * [OnAfterSourceInteractorChange()]
  * [OnBeforeSourceInteractorChange()]

## Details

##### Inheritance

* System.Object
* InteractorActionPublisherFacade

##### Namespace

* [Tilia.Interactions.Interactables.Interactors]

##### Syntax

```
public class InteractorActionPublisherFacade : MonoBehaviour
```

### Properties

#### ActiveAction

The current active Action.

##### Declaration

```
public virtual Action ActiveAction { get; }
```

#### Configuration

The Action that will be linked to the [SourceAction].

##### Declaration

```
public InteractorActionPublisherConfigurator Configuration { get; protected set; }
```

#### PublisherIdentifier

An indentifier for the publisher that is used by the Action Receiver to create the link between publisher and receiver.

##### Declaration

```
public string PublisherIdentifier { get; set; }
```

#### SourceAction

The Action to be monitored to control the interaction.

##### Declaration

```
public Action SourceAction { get; set; }
```

#### SourceInteractor

The source [InteractorFacade] that the action will be processed through.

##### Declaration

```
public InteractorFacade SourceInteractor { get; set; }
```

### Methods

#### ClearPublisherIdentifier()

Clears [PublisherIdentifier].

##### Declaration

```
public virtual void ClearPublisherIdentifier()
```

#### ClearSourceAction()

Clears [SourceAction].

##### Declaration

```
public virtual void ClearSourceAction()
```

#### ClearSourceInteractor()

Clears [SourceInteractor].

##### Declaration

```
public virtual void ClearSourceInteractor()
```

#### OnAfterPublisherIdentifierChange()

Called after [PublisherIdentifier] has been changed.

##### Declaration

```
protected virtual void OnAfterPublisherIdentifierChange()
```

#### OnAfterSourceActionChange()

Called after [SourceAction] has been changed.

##### Declaration

```
protected virtual void OnAfterSourceActionChange()
```

#### OnAfterSourceInteractorChange()

Called after [SourceInteractor] has been changed.

##### Declaration

```
protected virtual void OnAfterSourceInteractorChange()
```

#### OnBeforeSourceInteractorChange()

Called before [SourceInteractor] has been changed.

##### Declaration

```
protected virtual void OnBeforeSourceInteractorChange()
```

[Tilia.Interactions.Interactables.Interactors]: README.md
[SourceAction]: InteractorActionPublisherFacade.md#SourceAction
[InteractorActionPublisherConfigurator]: InteractorActionPublisherConfigurator.md
[InteractorFacade]: InteractorFacade.md
[PublisherIdentifier]: InteractorActionPublisherFacade.md#PublisherIdentifier
[SourceAction]: InteractorActionPublisherFacade.md#SourceAction
[SourceInteractor]: InteractorActionPublisherFacade.md#SourceInteractor
[PublisherIdentifier]: InteractorActionPublisherFacade.md#PublisherIdentifier
[SourceAction]: InteractorActionPublisherFacade.md#SourceAction
[SourceInteractor]: InteractorActionPublisherFacade.md#SourceInteractor
[SourceInteractor]: InteractorActionPublisherFacade.md#SourceInteractor
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[ActiveAction]: #ActiveAction
[Configuration]: #Configuration
[PublisherIdentifier]: #PublisherIdentifier
[SourceAction]: #SourceAction
[SourceInteractor]: #SourceInteractor
[Methods]: #Methods
[ClearPublisherIdentifier()]: #ClearPublisherIdentifier
[ClearSourceAction()]: #ClearSourceAction
[ClearSourceInteractor()]: #ClearSourceInteractor
[OnAfterPublisherIdentifierChange()]: #OnAfterPublisherIdentifierChange
[OnAfterSourceActionChange()]: #OnAfterSourceActionChange
[OnAfterSourceInteractorChange()]: #OnAfterSourceInteractorChange
[OnBeforeSourceInteractorChange()]: #OnBeforeSourceInteractorChange